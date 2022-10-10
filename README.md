# Pizzeria
Pizzeria is an hobby app to manage pizza orders placed by hungry people.

### Entities relationship

* Main enitities are **pizzas** which have **base ingredients** to show to users.
* **Logged Users** can make an **order** that contains one or more **single pizza orders** and **delivery address**
* **Single pizza order** has a **pizza** and optional **additional ingredients*. The price is the sum of the individual prices of pizza and ingredients.

### Using api

Two default users has been seeded into app:
* **admin@pizza.com** - **P@ssword1**
* **user@pizza.com** - **P@ssword1**

**I suggest you to use uploaded Postman Collection - PizzeriaApi.postman_collection.json**

Steps:
* Firstly, you need to check pizzas and additional ingredients and note their ids. You can do this without providing JWT token.
* Then you can log in and place single pizza orders (you need to provide token in header, it's works for 30 minutes). Note it's ids you will get from api.
* Finally you can join single pizza orders into order. Remember to provide correct Address.
* U can use other fuctionalities as well.

Api works with database, so		 remember to **"update-database"** before starting.
 


### TODO
In near future:
* DTOs validation
* Generating date of order in handler instead of providing it in post command
* Adding field currentPrice also to dditional ingredients, to not let the changes of the ingedients prices affect final price of order.
* Providing Admins methods like create pizza etc.
One day:
* Frontend
