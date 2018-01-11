const { getNumbers } = require('../db/numbers');

module.exports = (router, pool) => {
  router.get('/', async (req, res) => {
    const conn = await pool.getConnection();
    const numbers = await getNumbers(conn);
    await conn.close();
    res.render('home', { numbers });
  });
};
