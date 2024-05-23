using DesignPatterns.Extensions.Exceptions.CustomExceptions;
using DesignPatterns.Extensions.Exceptions.Documentation.BaseExceptionService;
using System.Diagnostics;

namespace DesignPatterns.Extensions.Exceptions.Documentation.Examples
{
    public class CalculatorService : BaseExceptionServices
    {
        public void Divide()
        {
            DesignConsole.Section("CalcualtorService");
            DesignConsole.Start("Sum");
            DesignConsole.ForeColor();
            try
            {
                Console.Write("Enter Number : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter Number : ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine($"Result : {c}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException : {ex}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException : {ex}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception");
                throw;
            }
            DesignConsole.End("Sum");
        }


        public void StackTraceFun(int a, int b)
        {
            DesignConsole.ForeColor();
            try
            {
                int res = a / b;
            }
            catch (Exception ex)
            {
                StackTrace trace = new(true);
                DesignConsole.Section();
                for (int i = 0; i < trace.FrameCount; i++)
                {
                    StackFrame stack = trace.GetFrame(i);
                    Console.WriteLine($"{i + 1} : {stack} \t Frame Count : {trace.FrameCount}");
                    Console.WriteLine($"GetMethod : {stack.GetMethod()}");
                    Console.WriteLine($"GetFileName : {stack.GetFileName()}");
                    Console.WriteLine($"GetFileColumnNumber : {stack.GetFileColumnNumber()}");
                    Console.WriteLine($"GetILOffset : {stack.GetILOffset()}");
                    Console.WriteLine("==========================================");
                }
                throw ex;
            }
        }


        public void DataExceptionFun(string parameter)
        {
            try
            {
                DataExceptionFunA(parameter);
            }
            catch (Exception ex)
            {
                //ex.Data["Info"] = "Info At Method";
                ex.Data["CalcualtorService.DataExceptionFun.Info"] = $"{ex.Message}";
                throw;
            }
        }
        public void DataExceptionFunA(string paramete)
        {
            try
            {
                DataExceptionFunB(paramete);
            }
            catch (Exception ex)
            {
                //ex.Data["Info"] = "Info At MethodA";
                ex.Data["CalcualtorService.DataExceptionFunA.Info"] = $"{ex.Message}";
                throw;
            }
        }
        public void DataExceptionFunB(string paramete)
        {
            try
            {
                var res = int.Parse(paramete);
            }
            catch (Exception ex)
            {
                ex.Data.Add("Time", DateTime.Now);
                ex.Data["CalcualtorService.DataExceptionFunB.Info"] = $"{ex.Message}";
                throw ex;
            }
        }


        public void InnerException(string parameter)
        {
            try
            {
                InnerException1(parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("CalcualtorService.InnerException3", ex);
            }
        }
        public void InnerException1(string parameter)
        {

            try
            {
                InnerException2(parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("CalcualtorService.InnerException1", ex);
            }
        }
        public void InnerException2(string parameter)
        {

            try
            {
                InnerException3(parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("CalcualtorService.InnerException2", ex);
            }
        }
        public void InnerException3(string parameter)
        {

            try
            {
                int res = int.Parse(parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("CalcualtorService.InnerException3", ex);
            }
        }


        #region HResult , HelpLink , Message , Source , Target Site

        #region HResult // کد خطا رخ داده را برمیگرداند
        #endregion

        #region HelpLink // لینک رهنمای رفع خطا را نمایش میدهد === لینک آمورش رفع خودمون رو میتوانیم بگذاریم
        #endregion

        #region Message //  پیامی که خطا ایجاد میکند یا همان پیامی که ما میدهیم
        #endregion

        #region Source // فضای نامی که خطا رخ داده است
        #endregion

        #region Target Site // اطلاعات که خطا در آنجا رخ داده است و تمام کلاس مورد نظر را ارایه میدهد
        #endregion

        #endregion


        #region Custome Exception Or Create OurException
        public int SumNumbers(int a, int b, string operation)
        {
            try
            {
                if (operation.Equals("+"))
                {
                    return a + b;
                }
                else
                {
                    //throw new InvalidOperationsException();
                    throw new CalculatorException(operation);
                }
            }
            catch (CalculatorException ex)
            {
                throw new Exception("", ex);
            }

            catch (Exception ex)
            {

                throw;
            }

        }
        #endregion

    }
}
