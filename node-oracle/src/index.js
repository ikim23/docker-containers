const oracledb = require('oracledb');

oracledb.getConnection({
  user: 'test_user',
  password: 'test_user',
  connectString: '(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=db)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)))',
}, (connErr, connection) => {
  if (connErr) {
    console.error(connErr.message);
  }
  console.log('Connection was successful!');
  connection.execute('SELECT * FROM numbers', (err, data) => {
    const rows = data.rows || [];
    rows.forEach(([myNumber]) => {
      console.log(myNumber);
    });
    connection.close((closeErr) => {
      if (closeErr) {
        console.error(closeErr.message);
      }
    });
  });
});
