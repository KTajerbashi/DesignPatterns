using DesignPattern.EndPoint.API.Exceptions.BaseExceptionService;
using DesignPattern.EndPoint.API.Exceptions.CustomExceptions;
using DesignPattern.EndPoint.API.Exceptions.Documentation.Examples;
using DesignPattern.EndPoint.API.Exceptions.Models;
using DesignPattern.EndPoint.API.Exceptions.Wrapper;
using System.Collections;
using System.Diagnostics;
using System.Net;

namespace DesignPattern.EndPoint.API.Exceptions.Container
{
    public class ExceptionContainer : BaseExceptionServices
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
                var result  = int.Parse(key);
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
                int res = a/b/0;
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

        #region Inner Exception
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
        #endregion

        #region Custom Exception
        /// <summary>
        /// Calculator Exception
        /// </summary>
        public void CalculatorExceptionExecute()
        {
            try
            {
                int a = 10;
                int b = 0;
                //int c = a/b;
                InvalidOperationsExceptionExecute(a, b, '+');
                NullDataExceptionsExecute(2);
                NotFoundExceptionsExecute(2);
                WebClientExceptionExecute();
            }
            catch (CalculatorException ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary>
        /// Invalid Operations Exception
        /// </summary>
        private void InvalidOperationsExceptionExecute(int a, int b, char operation)
        {
            try
            {
                if (operation.Equals('+'))
                {
                    var rr = a+b;
                }
                else
                {
                    throw new InvalidOperationsException(operation);
                }

            }
            catch (InvalidOperationsException ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary>
        /// NullData Exceptions
        /// </summary>
        public void NullDataExceptionsExecute(int id)
        {
            try
            {
                var data = DataList.Find(item => item.Id == id);
                if (data is null)
                {
                    throw new NullDataExceptions("اطلاعات خالی است");
                }
            }
            catch (NullDataExceptions ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary>
        /// NotFound Exceptions
        /// </summary>
        public void NotFoundExceptionsExecute(int id)
        {
            try
            {
                var data = DataList.Find(item => item.Id == id);
                if (data is null)
                {
                    throw new NullDataExceptions($"اطلاعاتی با شناسه {id}  یافت نشده است");
                }
            }
            catch (NullDataExceptions ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary>
        /// WebClient Exception
        /// </summary>
        public void WebClientExceptionExecute()
        {
            try
            {
                DesignConsole.ForeColor();
                WebClient webClient = new();
                try
                {
                    //var result = webClient.DownloadString("https://adsinternet.ir");
                    var result = webClient.DownloadString("https://google.com");
                    //Console.WriteLine($@"{Convert.ToByte(result)}");
                }
                catch (WebException ex) when (ex.Status != WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("WebExceptionStatus.ProtocolError");
                    throw;
                }
                catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
                {
                    Console.WriteLine("HttpStatusCode.InternalServerError");
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                    throw;
                }
                finally
                {
                    Console.WriteLine("WebClientException Service is Disconnected");
                    webClient.Dispose();
                    //throw new WebClientException("سرویس قطع است");
                }
            }
            catch (WebClientException ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        #endregion



        /// <summary>
        /// Debug Class For Logging
        /// </summary>
        public void DebugExecute()
        {
            try
            {
                Debug.WriteLine(":::::::::::::::::::::::DebugExecute");
                Debug.WriteLineIf(1 == 1, ":::::::::::::::::::::::DebugExecute");
                Debug.Assert(1 == 1, ":::::::::::::::::::::::DebugExecute");
                Debug.Fail(":::::::::::::::::::::::DebugExecute");
                Debug.Close();
                Debug.Unindent();
                Debug.Flush();
                Debug.Print(":::::::::::::::::::::::DebugExecute");
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
        /// Trace Class For Logging
        /// </summary>
        public void TraceExecute()
        {
            try
            {
                Trace.WriteLine("||||||||||||||||||||||||||||||TraceExecute");
                Trace.WriteLineIf(true, "||||||||||||||||||||||||||||||TraceExecute");
                Trace.TraceWarning("||||||||||||||||||||||||||||||TraceExecute");
                Trace.TraceError("||||||||||||||||||||||||||||||TraceExecute");
                Trace.TraceInformation("||||||||||||||||||||||||||||||TraceExecute");
                Trace.Refresh();
            }
            catch (Exception)
            {
                throw;
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

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
