using Microsoft.AspNetCore.Mvc;
using WebAPI.Implementation;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController(StoreService storeService) : ControllerBase
    {

        /// <summary>
        /// Loads all items stored in Database
        /// </summary>
        /// <returns>...</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreItem>>> GetAll()
        {
            return Ok(await storeService.GetAll());
        }

        /// <summary>
        /// Load specific item from Database by given Id number
        /// </summary>
        /// <param name="id">Individual Id Number</param>
        /// <returns>...</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<StoreItem>> GetItemById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var item = await storeService.GetItemById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        /// <summary>
        /// Creates new item for the store
        /// </summary>
        /// <param name="newItem">New item to create</param>
        /// <returns>...</returns>
        [HttpPost]
        public async Task<ActionResult<StoreItem>> CreateStoreItem([FromBody] StoreItem newItem)
        {
            if (newItem == null)
            {
                return BadRequest();
            }

            return Ok(await storeService.CreateStoreItem(newItem));
        }

        /// <summary>
        /// Updates item at given id number to the given new item
        /// </summary>
        /// <param name="id">Individual store item to change</param>
        /// <param name="updatedItem">Updated item to insert</param>
        /// <returns>...</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<StoreItem>> UpdateStoreItem(int id, [FromBody] StoreItem updatedItem)
        {
            if (updatedItem == null || id != updatedItem.Id)
            {
                return BadRequest(updatedItem);
            }

            return Ok(await storeService.UpdateStoreItem(id, updatedItem));
        }

        /// <summary>
        /// Removes item from given id number
        /// </summary>
        /// <param name="id">Individual store item</param>
        /// <returns>Deleted item from database</returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<StoreItem>> DeleteStoreItem(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var deletedItem = await storeService.DeleteStoreItem(id);

            if (deletedItem == null)
            {
                return NotFound();
            }

            return Ok(deletedItem);
        }
    }
}
