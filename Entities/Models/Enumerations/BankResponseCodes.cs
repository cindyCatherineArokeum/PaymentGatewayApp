using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.Enumerations
{
    public enum BankResponseCodes
    {
       Approved = 00,
       ReferToCardIssuer = 01,
       InvalidMerchant = 03,
       CardCapture = 04,
       Decline = 05,
       HonorWithId = 08,
       PartialApproval = 10,
       InvalidTransaction = 12,
       InvalidAmount = 13,
       InvalidCardNumber = 14,
       InvalidIssuer = 15,
       FormatError = 30,
       LostCardCapture = 41,
       StolenCardCapture = 43, 
       InsufficientFunds = 51,
       ExpiredCard = 54,
       InvalidPin = 55,
       TransactionNotAllowed = 57,
       ExceedsWithdrawalAmountLimit =61,
       RestrictedCardDecline = 62,
       SecurityViolation = 63,
       CryptographicFailureDecline = 88,
       DuplicateTransmissionDetected = 94,
       SystemErrorDecline = 96
       
    }
}
