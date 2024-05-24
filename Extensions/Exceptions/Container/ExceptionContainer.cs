using DesignPatterns.Extensions.Exceptions.CustomExceptions;
using DesignPatterns.Extensions.Exceptions.Documentation.Examples;
using DesignPatterns.Extensions.Exceptions.Documentation.Models;
using DesignPatterns.Extensions.Exceptions.Wrapper;
using System.Collections;
using System.Diagnostics;

namespace DesignPatterns.Extensions.Exceptions.Container
{
    public class ExceptionContainer
    {
        public WrapperContainer WrapperContainer { get; set; }
        public CalculatorService CalculatorService { get; set; }
        private List<UserModel> DataList { get; set; }
        public ExceptionContainer()
        {
            CalculatorService = new();
            WrapperContainer = new();
            DataList = new();
            DataList.Add(new UserModel { Id = 1, Name = "Kamran", Family = "Tajerbashi" });
            DataList.Add(new UserModel { Id = 2, Name = "Kaihan", Family = "Yousofzay" });
            DataList.Add(new UserModel { Id = 3, Name = "Mohammad", Family = "karimi" });
            DataList.Add(new UserModel { Id = 4, Name = "Javad", Family = "Khajezahdah" });
        }


        /// <summary>
        /// UsageErrorsExecute 
        /// اگر از با یک شی خالی بخواهیم کار کنیم این دسته از خطا ها رخ میدهد
        /// </summary>
        public void UsageErrorsExecute(int id)
        {
            try
            {
                var resultModel = DataList.Find(x => x.Id == id);
                Console.WriteLine($@"
Id : {resultModel.Id}
Name : {resultModel.Name}
Family : {resultModel.Family}
");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

        }

        /// <summary>
        /// Program Errors
        /// اگر بخواهیم یک مقداری را به مقدار دیگر تبدیل کنبم ک منطق اشتباهی داشته باشد 
        /// از ین دسته خطا ها رخ میدهد
        /// </summary>
        public void ProgramErrorsExecute(string key)
        {
            try
            {
                var result  = Int32.Parse(key);
                Console.WriteLine("Result : {0}", result);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }

        /// <summary>
        /// System Failures
        /// هرگاه منابع سیستم میزبان ظرفیت کافی نداشته باشد این دسته خطا اجرا میشود
        /// </summary>
        public void SystemFailuresExecute()
        {
            try
            {
                // نوشتن دستوراتی که رم سیستم را پر کند مانند یک حلقه بی نهایت
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }



        #region Stack Trace & Stack Frame
        /// <summary>
        /// Stack Trace & Stack Frame
        /// </summary>
        public void StackTrace_StackFrame_Execute()
        {
            try
            {
                StackTrace_StackFrame_ExecuteA();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
        private void StackTrace_StackFrame_ExecuteA()
        {
            try
            {
                StackTrace_StackFrame_ExecuteB();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }
        private void StackTrace_StackFrame_ExecuteB()
        {
            try
            {
                StackTrace_StackFrame_ExecuteC();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }
        private void StackTrace_StackFrame_ExecuteC()
        {
            try
            {
                int a = 10;
                int b = 15;
                int res = (a/b)/0;
            }
            catch (Exception ex)
            {
                StackTrace stackTrace = new StackTrace(true);
                for (int i = 0; i < stackTrace.FrameCount; i++)
                {
                    StackFrame frame = stackTrace.GetFrame(i);
                    Console.WriteLine($@"==> GetFileName : {frame.GetFileName()}");
                    Console.WriteLine($@"==> GetFileLineNumber : {frame.GetFileLineNumber()}");
                    Console.WriteLine($@"==> GetMethod : {frame.GetMethod()}");
                    Console.WriteLine("===================================");
                }
                throw ex;
            }
            finally
            {

            }
        }
        #endregion

        #region Data Exception
        /// <summary>
        /// Data Exception
        /// </summary>
        public void DataExceptionExecute()
        {
            try
            {
                DataExceptionExecuteA();
            }
            catch (Exception ex)
            {
                if (ex.Data.Count > 0)
                {
                    foreach (DictionaryEntry item in ex.Data)
                    {
                        Console.WriteLine($"Key : {item.Key} | Value : {item.Value}");
                    }
                }
                throw ex;
            }
            finally
            {

            }
        }
        private void DataExceptionExecuteA()
        {
            try
            {
                DataExceptionExecuteB();
            }
            catch (Exception ex)
            {
                ex.Data.Add("DataExceptionExecuteA", "Error is in the Catch of DataExceptionExecuteA");
                throw;
            }
            finally
            {

            }
        }
        private void DataExceptionExecuteB()
        {
            try
            {
                DataExceptionExecuteC();
            }
            catch (Exception ex)
            {
                ex.Data["ExceptionContainer.DataExceptionExecuteB"] = $"Error is in the Catch of DataExceptionExecuteB {DateTime.Now}";
                throw;
            }
            finally
            {

            }
        }
        private void DataExceptionExecuteC()
        {
            try
            {
                throw new Exception("این خطا در آخرین متد اتفاق افتاد.");
            }
            catch (Exception ex)
            {
                ex.Data["ExceptionContainer.DataExceptionExecuteC"] = "Error is in the Catch of DataExceptionExecuteC";
                throw ex;
            }
            finally
            {

            }
        }
        #endregion


        /// <summary>
        /// Inner Exception
        /// </summary>
        public void InnerExceptionExecute()
        {
            try
            {
                InnerExceptionExecuteA();
            }
            catch (Exception ex)
            {
                    Console.WriteLine($"Inner Exception : {ex.Message}");
                Exception exception = ex.InnerException;
                while (exception != null)
                {
                    Console.WriteLine($"Inner Exception : {exception.Message}");
                    exception = exception.InnerException;
                }
                throw;
            }
            finally
            {

            }
        }
        private void InnerExceptionExecuteA()
        {
            try
            {
                InnerExceptionExecuteB();
            }
            catch (Exception ex)
            {
                throw new Exception("InnerExceptionExecuteA", ex);
            }
            finally
            {

            }
        }
        private void InnerExceptionExecuteB()
        {
            try
            {
                InnerExceptionExecuteC();
            }
            catch (Exception ex)
            {
                throw new Exception("InnerExceptionExecuteB", ex);
            }
            finally
            {

            }
        }
        private void InnerExceptionExecuteC()
        {
            try
            {
                InnerExceptionExecuteD();
            }
            catch (Exception ex)
            {
                throw new Exception("InnerExceptionExecuteC", ex);
            }
            finally
            {

            }
        }
        private void InnerExceptionExecuteD()
        {
            try
            {
                throw new Exception("Inside Exception in Last Method");
            }
            catch (Exception ex)
            {
                throw new Exception("InnerExceptionExecuteD", ex);
            }
            finally
            {

            }
        }



        public void CallWebService()
        {
            try
            {
                WrapperContainer.CallWebService();
            }
            catch (WebClientException ex)
            {
                throw new WebClientException(ex.Message, ex);
            }
        }
    }
}
