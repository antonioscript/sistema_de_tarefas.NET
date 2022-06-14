using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        public string? Título { get; set; }
        public bool Concluído { get; set;}
        public DateTime Criação  { get; set; } = DateTime.Now;
        public DateTime Atualização  { get; set; } = DateTime.Now;
    }
}