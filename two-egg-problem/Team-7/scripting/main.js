export default ([,, z, l]) => {
  const {ceil: c, sqrt: v} = Math;
  const y = c(v(z));
  const x = (s, i) => {
    let f = s + i;
    for(f; f <= l; f += i) {
      console.log(`${f}\n${f >= l}`)
    }
    return f - i;
  }
  const b = x(1, y);
  const a = x(b, 1);
  console.log(`Floor ${a}`);
}

