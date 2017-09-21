using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XappsWeb.Models
{
    public enum Status {
        Pendente, Concluido
    }
    public class Task
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        [Display(Name = "Data de Criaçao")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "*")]
        public DateTime DataCriacao { get; set; }
        [Display(Name = "Tarefa")]
        [Required(ErrorMessage = "*")]
        public string Text { get; set; }
    }
}