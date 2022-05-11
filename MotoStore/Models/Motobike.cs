using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotoStore.Models
{
    public class Motobike
    {
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }
       
        [Display(Name="Имя")]  
         [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Name {get; set;}
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name="Компания")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Тип")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Цвет")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "наличие")]
        public string Existence { get; set; }
        [Required(ErrorMessage ="Введите дату")]
        [Display(Name = "Год")]
        
        public int YearManufacture { get; set; }
        [Display(Name = "Мощность")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public int Power { get; set; }
        

    }
}