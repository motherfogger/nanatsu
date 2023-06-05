INSERT INTO users (id, username, email, password) VALUES
    ('00000000-0000-0000-0000-000000000001', 'user1', 'user1@example.com', 'password1'),
    ('00000000-0000-0000-0000-000000000002', 'user2', 'user2@example.com', 'password2'),
    ('00000000-0000-0000-0000-000000000003', 'user3', 'user3@example.com', 'password3');

INSERT INTO posts (id, user_id, title, content) VALUES
    ('11111111-1111-1111-1111-111111111111', '00000000-0000-0000-0000-000000000001', 'First Post', 'This is the content of the first post.'),
    ('22222222-2222-2222-2222-222222222222', '00000000-0000-0000-0000-000000000001', 'Second Post', 'This is the content of the second post.'),
    ('33333333-3333-3333-3333-333333333333', '00000000-0000-0000-0000-000000000002', 'Third Post', 'This is the content of the third post.');

INSERT INTO comments (id, post_id, user_id, content) VALUES
    ('aaaaaaa0-0000-0000-0000-000000000001', '11111111-1111-1111-1111-111111111111', '00000000-0000-0000-0000-000000000002', 'This is a comment on the first post.'),
    ('aaaaaaa0-0000-0000-0000-000000000002', '11111111-1111-1111-1111-111111111111', '00000000-0000-0000-0000-000000000003', 'This is another comment on the first post.'),
    ('bbbbbbb0-0000-0000-0000-000000000001', '22222222-2222-2222-2222-222222222222', '00000000-0000-0000-0000-000000000001', 'This is a comment on the second post.'),
    ('bbbbbbb0-0000-0000-0000-000000000002', '22222222-2222-2222-2222-222222222222', '00000000-0000-0000-0000-000000000003', 'This is another comment on the second post.'),
    ('ccccccc0-0000-0000-0000-000000000001', '22222222-2222-2222-2222-222222222222', '00000000-0000-0000-0000-000000000002', 'This is a comment on the third post.');

