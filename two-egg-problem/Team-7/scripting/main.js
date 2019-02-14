export default ([, , z, l]) => {
  l = parseInt(l);
  const { ceil: c, sqrt: v } = Math;
  const y = c(v(z));
  const x = (f, i, final) => {
    do { f += i; console.log(`${f}\n${f >= l}`); } while(f < l);
    return final ? f : f - i;
  };
  console.log(`Floor ${x(x(0, y), 1, true)}`)
};
