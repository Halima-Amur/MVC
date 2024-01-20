using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{

		public class ToDo
		{
			public int Id { get; set; }

        [Required(ErrorMessage ="ToDo Name is required")]

        public  string name { get; set; }

            public bool isFinished { get; set; }

            public string? descriotion { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}


