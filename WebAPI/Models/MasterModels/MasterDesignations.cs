using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAPI.Models.MasterModels
{
	public class MasterDesignations
	{
		[Key]
		public int DesignationId { get; set; }
		public string DesignatioName { get; set; }
		public int DepartmentId { get; set; }		

	}
}
