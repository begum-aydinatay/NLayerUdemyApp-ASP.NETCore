using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }

        //Static factory methods

        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }

        //when you don't want to return any data
        public static CustomResponseDto<T> Success(int statusCode) 
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }

        public static CustomResponseDto<T> Failure(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { Errors = errors, StatusCode = statusCode };
        }

        public static CustomResponseDto<T> Failure(int statusCode, string error)
        {
            return new CustomResponseDto<T> { Errors = new List<string> { error }, StatusCode = statusCode };
        }
    }
}
