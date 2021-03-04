import { environment } from './environment.prod';

describe('Environment', () => {
  let env: any;

  beforeEach(() => {
    env = environment;
  });
  test('production should be true', () => {
    expect(env.production).toBe(true);
  });
});
