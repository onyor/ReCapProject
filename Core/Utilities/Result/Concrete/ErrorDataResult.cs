using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(data,false,message)
        {

        }
        public ErrorDataResult(T data):base(data,false)
        {

        }
        // Data'yı boş döndürmek istersek
        public ErrorDataResult(string message):base(default,false,message)
        {

        }
        public ErrorDataResult():base(default,false)
        {

        }
    }
}
