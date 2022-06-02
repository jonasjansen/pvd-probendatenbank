namespace ProbenDatenbank.Data.Entity
{
    public class BaseEntity
    {
        protected readonly Database Database;

        private int? _id;

        public int Id
        {
            get
            {
                if (_id.HasValue)
                {
                    return (int) _id;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value != 0)
                {
                    _id = value;                    
                }
            }
        }

        protected BaseEntity()
        {
            Database = new Database();
        }

        /// <summary>
        /// Save entity.
        /// If this entity has an Id, the existing item will be update in the database.
        /// Otherwise a new item will be created in the database.
        /// </summary>
        public virtual void Save()
        {
            if (HasId())
            {
                Update();
            }
            else
            {
                Create();
            }
        }

        /// <summary>
        /// Update existing item in the database. Function has to be implemented by child class.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual void Update()
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// Load item from database.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void Load(int Id)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Create new item in the database. Function has to be implemented by child class.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual void Create()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Return if entity has an Id set.
        /// </summary>
        /// <returns></returns>
        protected virtual bool HasId()
        {
            return _id.HasValue;
        }
    }
}