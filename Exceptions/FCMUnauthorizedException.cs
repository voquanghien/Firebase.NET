using System.Net;

namespace FirebaseNet.Exceptions
{
    public class FCMUnauthorizedException : FCMException
    {
        public FCMUnauthorizedException() : base(HttpStatusCode.Unauthorized, "Unauthorized")
        {
        }
    }
}