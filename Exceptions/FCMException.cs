﻿using System;
using System.Net;

namespace FirebaseNet.Exceptions
{
    public class FCMException : Exception
    {
        public FCMException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public FCMException() : base()
        {
        }

        /// <summary>
        /// The HttpStatusCode returned by FCM
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}