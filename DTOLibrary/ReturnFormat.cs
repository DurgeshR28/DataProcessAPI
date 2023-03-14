using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public class ReturnFormat
    {
        public bool success { get; set; }


        public object output { get; set; }


        public string exceptiontrace { get; set; }



        public ReturnFormat()
        {

        }



        /// <summary>
        /// return a format that all api will receive
        /// </summary>
        /// <param name="returnFormat"></param>
        /// <returns></returns>
        public static ReturnFormat InstanceReturnFormat(ReturnFormat returnFormat)
        {


            return new ReturnFormat
            {
                success = returnFormat.success,
                output = returnFormat.output,
                exceptiontrace = returnFormat.exceptiontrace
            };

        }
    }
}
