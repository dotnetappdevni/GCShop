using GoCompareShop.CustomerService.Interface;
using GoCompareShop.DAL;
using GoCompareShop.Models;
using Microsoft.Extensions.Logging;
using NLog;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GoCompareShop.CustomerService
{
    public class CustomerServices : ICustomerInterface
    {
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();


        public CustomerServices(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;

        }

        /// <summary>
        /// Gets all active customers
        /// </summary>
        /// <returns>List<Customer> a list of customer</returns>
        public List<Customer> GetAll()
        {
            return _dbContext.Customers.Where(w => w.IsDeleted == false && w.IsActive == true).ToList();
        }

        /// <summary>
        /// Gets a single customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a single customer</returns>
        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.Where(w => w.Id == id & w.IsDeleted == false && w.IsActive == true).FirstOrDefault();
        }

        /// <summary>
        /// Creates a Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>ErrorObject cuustom error object</returns>
        public GoCShopErrorObject Add(Customer customer)
        {
            GoCShopErrorObject errorObject = new GoCShopErrorObject();
            _logger.Error("Entered the Update customer method  ");
            try
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                errorObject.Succeeded = true;
                errorObject.Messages.Add("Customer Created Successfully");
                _logger.Info("Customer created successfully");
                _logger.Error("Exited the Update customer method");
            }
            catch (Exception ex)
            {
                errorObject.Succeeded = false;
                errorObject.Exception = ex;
                _logger.Error("Exception occurred in the add customer method service", ex);
            }
            _dbContext.SaveChanges();
            return errorObject;
        }

        public GoCShopErrorObject Update(Customer customer)
        {
            GoCShopErrorObject errorObject = new GoCShopErrorObject();
            _logger.Error("Entered the Update customer method  ");

            try
            {
                var customerToUpdate = _dbContext.Customers.Where(w => w.Id == customer.Id && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
                if (customerToUpdate != null)
                {
                    _dbContext.Entry(customerToUpdate).CurrentValues.SetValues(customer);
                    try
                    {
                        _dbContext.SaveChanges();
                        errorObject.Succeeded = true;
                        errorObject.Messages.Add($"Customer Successfully updated {customer.Id}");
                        _logger.Error("Update customer method completed successfully");
                        _logger.Error("Exited the Update customer method  ");

                    }
                    catch (Exception ex)
                    {
                        errorObject.Succeeded = false;
                        errorObject.ExceptionErrors.Add($"Exception occurred while updating customer {customer.Id}");
                        errorObject.Exception = ex;
                        _logger.Error("Exception occurred in the Update customer method service", ex);


                    }
                }
                else
                {

                    errorObject.Errors.Add(new GCError { Field= "errorMessage", Message = "Customer Not Found please ensure customer Id correct." });
                    errorObject.Succeeded = false;
                }

            }

            catch (Exception ex)
            {
                errorObject.Succeeded = false;

                errorObject.ExceptionErrors.Add($"Exception occurred while updating customer {customer.Id}");
                errorObject.Exception = ex;
                _logger.Error("Exception occurred in the Update customer method service", ex);


            }
            return errorObject;
        }



        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>ErrorObject cuustom error object</returns>
        public GoCShopErrorObject Delete(int customerId)
        {
            GoCShopErrorObject errorObject = new GoCShopErrorObject();
            var customerToDelete = _dbContext.Customers.Find(customerId);
            _logger.Error("Entered the Delete customer method  ");
            if (customerToDelete != null)
            {
                try
                {
                    _dbContext.Customers.Remove(customerToDelete);
                    _dbContext.SaveChanges();
                    errorObject.Succeeded = true;
                    errorObject.Messages.Add("Customer Deleted");
                    _logger.Info("Customer Deleted successfully");
                    _logger.Error("Exited the Delete customer method  ");

                }
                catch (Exception ex)
                {
                    errorObject.Succeeded = false;
                    errorObject.ExceptionErrors.Add(ex.Message);

                    errorObject.Exception = ex;
                    _logger.Error("Exception occurred in the Delete customer method service", ex);

                }
            }
            else
            {
                errorObject.Errors.Add(new GCError { Field = "errorMessage", Message = "Customer Not Found please ensure customer Id correct." });
                errorObject.Succeeded = false;
            }



            return errorObject;
        }
    }
}
