using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Gönderilen adres boş olamaz");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Yolladığınız adres boş olamaz");
            RuleFor(x => x.SenderMail).EmailAddress().WithMessage("email tipinde giriniz");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("email tipinde giriniz");
        }
    }
}
