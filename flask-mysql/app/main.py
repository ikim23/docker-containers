from flask import Flask
from flaskext.mysql import MySQL

app = Flask(__name__)
mysql = MySQL()
app.config['MYSQL_DATABASE_HOST'] = 'db'
app.config['MYSQL_DATABASE_DB'] = 'test'
app.config['MYSQL_DATABASE_USER'] = 'user'
app.config['MYSQL_DATABASE_PASSWORD'] = 'user'
mysql.init_app(app)

@app.route('/')
def hello_world():
    db = mysql.connect()
    cursor = db.cursor()
    query_string = 'SELECT * FROM numbers'
    cursor.execute(query_string)
    data = cursor.fetchall()
    db.close()
    return 'Selected data: ' + str(data)
