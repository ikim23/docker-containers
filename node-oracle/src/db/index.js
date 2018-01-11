const oracledb = require('oracledb');

module.exports = (callback) => {
  oracledb.fetchAsBuffer = [oracledb.BLOB];
  oracledb.autoCommit = true;
  oracledb.createPool({
    user: process.env.USER,
    password: process.env.PASSWORD,
    connectString: process.env.CONNECT_STRING,
  }, (error, pool) => {
    callback(pool);
  });
};
