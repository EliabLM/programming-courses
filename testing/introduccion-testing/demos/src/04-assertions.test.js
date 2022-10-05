// Matchers

test("test obj", () => {
  const data = { name: "Eliab" };
  data.lastName = "Lopez";

  expect(data).toEqual({ name: "Eliab", lastName: "Lopez" });
});

test("should be null", () => {
  const data = null;

  expect(data).toBeNull();
  expect(data).toBeDefined();
  expect(data).not.toBeUndefined();
});

test("should be boolean", () => {
  const data = true;

  expect(data).toEqual(true);

  expect(0).toBeFalsy();
  expect("").toBeFalsy();
  expect(false).toBeFalsy();
});

test("should be strings", () => {
  const data = "Christoph";

  // Receive a regular expression
  expect(data).toMatch(/stop/);
});

test("should be an array", () => {
  const data = [1, 2, 3, 4];

  expect(data).toContain(3);
});
