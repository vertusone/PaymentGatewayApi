using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaymentGatewayApi.Models;

namespace PaymentGatewayApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public ActionResult<PaymentResponse> ProcessPayment([FromBody] PaymentRequest request)
        {
            // Simulate validation
            if (string.IsNullOrWhiteSpace(request.CardNumber) || request.Amount <= 0)
            {
                return BadRequest(new PaymentResponse
                {
                    Success = false,
                    Message = "Invalid payment details."
                });
            }

            // Simulate bank processing (random approval)
            var approved = request.CardNumber.EndsWith("5"); // Simple rule for demo
            var transactionId = Guid.NewGuid().ToString();

            return Ok(new PaymentResponse
            {
                Success = approved,
                TransactionId = transactionId,
                Message = approved ? "Payment approved by bank." : "Payment declined by bank."
            });
        }
    }
} 