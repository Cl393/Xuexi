﻿using System;

namespace ExceptionFilters
{
    class Program
    {
        //    static void Main()
        //    {
        //        try
        //        {
        //            ThrowWithErrorCode(405);

        //        }
        //        catch (MyCustomException ex) when (ex.ErrorCode == 405)
        //        {
        //            Console.WriteLine($"Exception caught with filter {ex.Message} and {ex.ErrorCode}");
        //        }

        //        catch (MyCustomException ex)
        //        {
        //            Console.WriteLine($"Exception caught {ex.Message} and {ex.ErrorCode}");
        //        }

        //        Console.ReadLine();
        //    }

        //    public static void ThrowWithErrorCode(int code)
        //    {
        //        throw new MyCustomException("Error in Foo") { ErrorCode = code };
        //    }
        //}

    }
    class Test
    {
        static int Calc(int x) { return 10 / x; }
        static void Main()
        {

            try
            {
                int y = Calc(5);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
            Console.ReadLine();
        }
    }
}
