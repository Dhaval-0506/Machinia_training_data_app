/*using MongoDB.Bson.Serialization.Attributes;

namespace Machinia_Mongodb_Crud_Api.data
{
    public class CodeForMongoOpr
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }   //{"Name":"puru","Age":700,"Balance":77}
        public int Age { get; set; }
        public int Balance { get; set; }

        public List<string> Act { get; set; }
    }
}
*/



using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Machinia_Mongodb_Crud_Api.data
{
    [BsonIgnoreExtraElements]
    public class Address
    {
        [Required(ErrorMessage = "Detailed address is required")]
        public string? detailedAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string? city { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string? state { get; set; }

        [Required(ErrorMessage = "Pin code is required")]
        public string? pinCode { get; set; }
    }
    [BsonIgnoreExtraElements]
    public class Mongodb_Model
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public ObjectId _id = new ObjectId();

        public string? Id { get; set; }

        [Required(ErrorMessage = "Center name is required")]
        [StringLength(40, ErrorMessage = "Center name cannot be longer than 40 characters")]
        public string? centerName { get; set; }

        [Required(ErrorMessage = "Center code is required")]
        [RegularExpression(@"^[a-zA-Z0-9]{12}$", ErrorMessage = "Center code should be 12 characters / alphanumeric")]
        public string? centerCode { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public Address? address { get; set; } = new Address();

        [Range(0, int.MaxValue, ErrorMessage = "Student capacity must be a positive integer")]
        public int studentCapacity { get; set; }

        [MinLength(1, ErrorMessage = "At least one course must be offered")]
        public List<string>? coursesOffered { get; set; } = new List<string>();

        [BsonElement("Created______On")]
        public long CreatedOn { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[cC][oO][mM]$", ErrorMessage = "Invalid email address")]
        public string? contactEmail { get; set; }

        [Required(ErrorMessage = "Contact phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number")]
        public string? contactPhone { get; set; }
    }



}
