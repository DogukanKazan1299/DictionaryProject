using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Usermail).NotEmpty().WithMessage("Kullanıcı maili Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı Boş Geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez");
        }

    }
}
