// Group test cases

describe("Set 1", () => {
  beforeAll(() => {
    console.log("BeforeAll"); // Here in the beforeAll we can setup a database
  });

  afterAll(() => {
    console.log("AfterAll"); // Set down database
  });

  beforeEach(() => {
    console.log("BeforeEach");
  });

  afterEach(() => {
    console.log("AfterEach");
  });

  test("Case 1", () => {
    console.log("Case 1");
    expect(1 + 1).toBe(2);
  });

  test("Case 2", () => {
    console.log("Case 2");
    expect(1 + 1).toBe(2);
  });

  describe("Set 2", () => {
    test("Case 3", () => {
      console.log("Case 3");
      expect(1 + 1).toBe(2);
    });

    test("Case 4", () => {
      console.log("Case 4");
      expect(1 + 1).toBe(2);
    });
  });
});
