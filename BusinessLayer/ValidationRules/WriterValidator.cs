using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı minimum 2 karakter olmalı");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı maximum 50 karakter olmalı");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı minimum 2 karakter olmalı");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı maximum 50 karakter olmalı");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında boş geçilemez");
      

        }
    }
}
