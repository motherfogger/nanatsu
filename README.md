# nanatsu
.net 7 template with postgresql and dapper for database

<br>
<br>


### create database
```bash
sudo -u postgres psql
postgres=# create database db1;
postgres=# create user admin with encrypted password 'admin';
postgres=# grant all privileges on database db1 to admin;

```


### optional: check DB activity, pool, etc, run as SQL
```sql
SELECT * FROM pg_stat_activity;
```



### build and run
```bash
dotnet run
```
visit  http://localhost:5238/index.html to see the swagger API available