1. // GET /api/v1/products/{id}
   Before adding to the cache
   200 OK 5.74 s 271 B
   
   After adding to the cache once it had querried
   200 OK 214 ms 271 B

2. // GET /api/v1/products
   
   When getting all the products, Before adding to the cache
   200 OK 200 ms 121.62 KB

   Added a new product and the cache is updated to make the cache up to date. After adding to the cache once it had querried
   200 OK 18 ms 121.73 KB
