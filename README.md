# Payment Gateway API (.NET 9)

A simplified payment gateway built with ASP.NET Core 9.0. This API simulates processing credit card payments between a Merchant (Client) and a Bank.

## Features
- Accepts payment requests with credit card details
- Validates input
- Simulates bank approval/decline
- Returns transaction status and reference

## Workflow
1. Merchant sends a POST request to `/api/payment` with card details and amount.
2. API validates the request.
3. API simulates sending the payment to the bank (random approval logic).
4. API returns the result (approved/declined) and a transaction ID.

## How to Run
1. **Requirements:** .NET 9 SDK
2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```
3. **Run the API:**
   ```bash
   dotnet run
   ```
4. **Test the endpoint:**
   Send a POST request to `https://localhost:5001/api/payment` (or the shown port) with JSON body:
   ```json
   {
     "cardNumber": "1234567890123455",
     "cardHolder": "John Doe",
     "expiry": "12/26",
     "cvv": "123",
     "amount": 100.00
   }
   ```
   - If the card number ends with `5`, the payment is approved (demo logic).

## Example Response
```json
{
  "success": true,
  "transactionId": "...",
  "message": "Payment approved by bank."
}
```