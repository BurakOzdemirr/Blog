using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("Blog başlığı en az 3 karakter olmalıdır.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığı en fazla 150 karakter uzunluğunda olmalıdır.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog fotoğraf alanı boş bırakılamaz");
        }
    }
}
