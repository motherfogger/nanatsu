const axios = require('axios');
const URL = "http://localhost:5238/Post";


test('testGetPosts', async () => {

    const response = await axios.get(URL);
    expect(response.status).toBe(200);

    var sample = [
        {
            id: "11111111-1111-1111-1111-111111111111",
            title: "First Post",
            body: null,
            author: "00000000-0000-0000-0000-000000000000",
            created_at: "2023-06-04T16:52:05.635061",
            updated_at: "0001-01-01T00:00:00"
        },
        {
            id: "22222222-2222-2222-2222-222222222222",
            title: "Second Post",
            body: null,
            author: "00000000-0000-0000-0000-000000000000",
            created_at: "2023-06-04T16:52:05.635061",
            updated_at: "0001-01-01T00:00:00"
        },
        {
            id: "33333333-3333-3333-3333-333333333333",
            title: "Third Post",
            body: null,
            author: "00000000-0000-0000-0000-000000000000",
            created_at: "2023-06-04T16:52:05.635061",
            updated_at: "0001-01-01T00:00:00"
        }
    ];
    expect(response.data).toEqual(sample);
});