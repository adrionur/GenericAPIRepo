using System.Net;

namespace GenericAPIRepo.Entities
{
    public class ServiceResult<T>
    {
        public T ResponseData { get; set; }
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
