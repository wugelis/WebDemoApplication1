using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleDBModels.Entities
{
	public class Code
	{
		[StringLength(50)]
		public string CodeType {get; set;}


		[StringLength(50)]
		public string CodeID {get; set;}


		[StringLength(50)]
		public string CodeDesc {get; set;}


	}

}
