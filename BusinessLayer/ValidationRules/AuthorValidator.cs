using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator: AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar Başlığı boş geçilemez.");
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adı boş geçilemez.");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazar Fotoğrafı boş geçilemez.");
            RuleFor(x => x.AboutShort).NotEmpty().WithMessage("Yazar Statüsü boş geçilemez.");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Yazar Mail adresi boş geçilemez.");
            RuleFor(x => x.Facebook).NotEmpty().WithMessage("Yazar facebook adresi boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Yazar şifresi boş geçilemez.");
            RuleFor(x => x.Github).NotEmpty().WithMessage("Yazar github adresi boş geçilemez.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Yazar telefon numarası boş geçilemez.");
            RuleFor(x => x.Twitter).NotEmpty().WithMessage("Yazar twitter adresi boş geçilemez.");
            RuleFor(x => x.Linkedin).NotEmpty().WithMessage("Yazar linkedin adresi boş geçilemez.");
            RuleFor(x => x.Instagram).NotEmpty().WithMessage("Yazar instagram adresi boş geçilemez.");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Yazar hakkımda boş geçilemez.");
        }
    }
}
