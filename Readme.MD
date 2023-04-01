
/**
 * 
 * This is a simple CRUD API built using the Machinia_Mongodb_Crud_Api.data library and .NET 6.0.
 * The API allows you to perform basic CRUD operations on a MongoDB database.
 * 
 * SETUP INSTRUCTIONS
 * 
 * 1. Make sure you have MongoDB installed and running on your local machine.
 * 2. Clone this repository and open the solution in Visual Studio 2022 or later.
 * 3. Open the `appsettings.json` file and modify the connection string to point to your MongoDB instance.
 * 4. Run the program.
 * 
 * USAGE
 * 
 * The API exposes the following endpoints:
 * 
 * 1. GET /get_records
 *    Returns all records in the database.
 * 
 * 2. GET /get_records/{id}
 *    Returns the record with the specified ID.
 * 
 * 3. POST /insert_new_records
 *    Creates a new record in the database.
 *    Accepts a JSON payload in the following format:
 *    
 *    {
 *   "Id": "11115",
 *   "centerName": "Center2",
 *   "centerCode": "SH1256as87D",
 *   "address": {
 *       "detailedAddress": "abc",
 *       "city": "Solapur",
 *       "state": "MH",
 *       "pincode": "123123"
 *   },
 *   "studentCapacity": 20,
 *   "coursesOffered": [
 *       "Course 1",
 *       "Course 2",
 *       "Course 3"
 *   ],
 *   "contactEmail": "abbc@gmail.om",
 *   "contactPhone": "1112211133"
 *	}
 * 
 *   Author : Dhaval