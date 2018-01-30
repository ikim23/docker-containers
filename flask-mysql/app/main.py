from flask import Flask, jsonify, request
from flaskext.mysql import MySQL
import os

app = Flask(__name__)
mysql = MySQL()
app.config['MYSQL_DATABASE_HOST'] = 'db'
app.config['MYSQL_DATABASE_DB'] = os.environ['MYSQL_DATABASE']
app.config['MYSQL_DATABASE_USER'] = os.environ['MYSQL_USER']
app.config['MYSQL_DATABASE_PASSWORD'] = os.environ['MYSQL_PASSWORD']
mysql.init_app(app)

@app.route('/')
def get_index():
    return app.send_static_file('index.html')

@app.route('/numbers', methods=['GET'])
def get_numbers():
    db = mysql.connect()
    cursor = db.cursor()
    query_string = 'SELECT * FROM numbers'
    cursor.execute(query_string)
    data = cursor.fetchall()
    db.close()
    return jsonify({
        'numbers': data
    })
