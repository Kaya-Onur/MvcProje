﻿using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail Alanını Boş Geçemezsiniz.");
            

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(1000).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız.");

            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("İçeriği Boş Geçemezsiniz.");
    
            

        }

       
    }
}
