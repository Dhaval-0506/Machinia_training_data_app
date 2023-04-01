/*using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations.ElementNameValidators;

namespace Machinia_Mongodb_Crud_Api.data
{
    public class MongoOprService
    {
        private readonly IMongoCollection<CodeForMongoOpr> _movies; //db method to invoke

        public MongoOprService(IOptions<MongodbConfigSetting> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionSring);
            _movies = mongoClient.GetDatabase(options.Value.DatabaseName)
                .GetCollection<CodeForMongoOpr>(options.Value.CollectionNameInDb);

        }
        public async Task<List<CodeForMongoOpr>> Get()=>
            await _movies.Find(_ => true).ToListAsync();

        public async Task<CodeForMongoOpr> Get(string id) =>
            await _movies.Find(m => m.Id == id).FirstOrDefaultAsync();

        public async Task Create(CodeForMongoOpr newName) =>
            await _movies.InsertOneAsync(newName);
        public async Task Update(string id, CodeForMongoOpr updateRec) =>
            await _movies.ReplaceOneAsync(m => m.Id == id, updateRec);


        public async Task Remove(string id) => 
            await _movies.DeleteOneAsync(m => m.Id == id);

    }
}
*/
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations.ElementNameValidators;

namespace Machinia_Mongodb_Crud_Api.data
{
    public class Mongodb_Api_manager
    {
        private readonly IMongoCollection<Mongodb_Model> _Record_To_Process; //db method to invoke

        public Mongodb_Api_manager(IOptions<Mongodb_Configuration> options)
        {
            var mongoClient = new MongoClient("mongodb://localhost:20000/Training_Center_Database");
            _Record_To_Process = mongoClient.GetDatabase(options.Value.DatabaseName)
                .GetCollection<Mongodb_Model>(options.Value.CollectionNameInDb);

        }
        public async Task<List<Mongodb_Model>> Get() =>
            await _Record_To_Process.Find(_ => true).ToListAsync();
        public async Task<Mongodb_Model> Get(string id) =>
            await _Record_To_Process.Find(self => self.Id == id).FirstOrDefaultAsync();

        public async Task Create(Mongodb_Model Record_to_insert)
        {            
            await _Record_To_Process.InsertOneAsync(Record_to_insert);

        }

    }
}
