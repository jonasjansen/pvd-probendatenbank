using System;
using System.Collections.Generic;
using System.Linq;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class BaseCollection
    {
        protected SortedDictionary<int, BaseEntity> Items = new SortedDictionary<int, BaseEntity>();
        private int collectionId;
        const String DatabaseTable = "";
        public bool CanLoadItemsFromDatabase { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="canLoadItemsFromDatabase">Defines, if Items can be loaded from database, in case on Items are assigned to this class.</param>
        public BaseCollection(bool canLoadItemsFromDatabase = true)
        {
            collectionId = 0;
            CanLoadItemsFromDatabase = canLoadItemsFromDatabase;
        }

        /// <summary>
        /// Load items from database, create entity objects from received data and store them in the items list.
        /// This function has to be implemented by each child class.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void LoadItemList()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Provides a dictionary of entity items. If the list is empty, it will be filled by the LoadItemList() function
        /// which receives the information from the database.
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<int, BaseEntity> GetItemsDictionary()
        {
            if (!HasItems() && CanLoadItemsFromDatabase)
            {
                LoadItemList();
            }

            return Items;
        }

        /// <summary>
        /// Provides a list of entity items. If the list is empty, it will be filled by the LoadItemList() function
        /// which receives the information from the database.
        /// </summary>
        /// <returns></returns>
        public List<BaseEntity> GetItems()
        {
            if (!HasItems() && CanLoadItemsFromDatabase)
            {
                LoadItemList();
            }

            return Items.Values.ToList();
        }

        /// <summary>
        /// Save all items from Items list.
        /// </summary>
        public virtual void SaveItems()
        {
            foreach (BaseEntity item in Items.Values)
            {
                item.Save();
            }
        }

        /// <summary>
        /// Add item to collection.
        /// CollectionId is used as a class internal id within the Items dictionary. Even though the added entities have an attribute "id",
        /// it cannot be used: The Id is not always set, when an entity is added to the dictionary. 
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(BaseEntity item)
        {
            //TODO: Check if item is already in Items 
            collectionId++;
            Items[collectionId] = item;
        }
        
        /// <summary>
        /// Add item to collection at specific position.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="collectionId"></param>
        public void AddItem(BaseEntity item, int collectionId)
        {
            Items[collectionId] = item;
        }
        

        /// <summary>
        /// Get item from collection.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public BaseEntity GetItem(int collectionId)
        {
            if (!Items.ContainsKey(collectionId))
            {
                throw new KeyNotFoundException();
            }

            return Items[collectionId];
        }

        // Delete item from collection.
        public void DeleteItem(int collectionId)
        {
            Items.Remove(collectionId);
        }

        /// <summary>
        /// Check if collection contains any items.
        /// </summary>
        /// <returns></returns>
        public bool HasItems()
        {
            return Items.Count > 0;
        }
    }
}