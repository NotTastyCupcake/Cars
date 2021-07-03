using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    [Table("Table")]
    public class CarModel
    {
        [Key]
        public int CarID { get; set; }
        [Required(ErrorMessage = "Введите марку автомобиля")]
        [Display(Name = "Марка авто")]
        public string Mark { get; set; }

        [Required(ErrorMessage = "Введите номер автомобиля")]
        [Display(Name = "Номер")]
        [RegularExpression(@"^[А-Я]{2}[0-9]{3}[А-Я]{1}[0-9]{2}$", ErrorMessage = "Введите правильный номер автомобиля")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Выбирите цвет автомобиля")]
        [Display(Name = "Цвет")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Введите год выпуска автомобиля")]
        [Display(Name = "Год выпуска")]
        [Range(1950, 2021, ErrorMessage = "Введите правильный год выпуска")]
        public int Year { get; set; }
        
    }
}
