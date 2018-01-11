async function getNumbers(conn) {
  const result = await conn.execute('SELECT * FROM numbers');
  const numbers = result.rows || [];
  return numbers.map(number => ({ number }));
}

module.exports = {
  getNumbers,
};
