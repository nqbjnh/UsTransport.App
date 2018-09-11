using System;

namespace UsTransport.Checking.Models
{
    [Serializable]
    public class Response
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public Response()
        {
            Code = Error.SUCCESS.Code;
            Message = Error.SUCCESS.Message;
        }

        public Response Success(object data = null)
        {
            Code = Error.SUCCESS.Code;
            Message = Error.SUCCESS.Message;
            Data = data;
            return this;
        }

        public Response Failed(object data = null)
        {
            Code = Error.FAILED.Code;
            Message = Error.FAILED.Message;
            Data = data;
            return this;
        }

        public Response System(object data = null)
        {
            Code = Error.SYSTEM.Code;
            Message = Error.SYSTEM.Message;
            Data = data;
            return this;
        }

        public Response SetData(object data)
        {
            Data = data;
            return this;
        }
    }

    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public static Error SUCCESS = new Error { Code = 0, Message = "Thành công" };
        public static Error FAILED = new Error { Code = 1, Message = "Thất bại" };
        public static Error SYSTEM = new Error { Code = 2, Message = "Lỗi hệ thống" };
    }
}