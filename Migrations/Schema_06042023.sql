CREATE TABLE users (
    id UUID PRIMARY KEY,
    username VARCHAR(255),
    status INT CHECK (status BETWEEN 1 AND 6),
    email VARCHAR(255),
    password VARCHAR(255)
    created_at TIMESTAMP DEFAULT NOW(),
);

CREATE UNLOGGED TABLE posts (
    id UUID PRIMARY KEY,
    user_id UUID,
    title VARCHAR(255),
    content TEXT,
    status INT CHECK (status BETWEEN 1 AND 6),
    created_at TIMESTAMP DEFAULT NOW(),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE UNLOGGED TABLE comments (
    id UUID PRIMARY KEY,
    post_id UUID,
    user_id UUID,
    content TEXT,
    created_at TIMESTAMP DEFAULT NOW(),
    FOREIGN KEY (post_id) REFERENCES posts(id),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE UNLOGGED TABLE shares (
    id UUID PRIMARY KEY,
    post_id UUID,
    link_id VARCHAR(7),
    created_at TIMESTAMP DEFAULT NOW(),
    FOREIGN KEY (post_id) REFERENCES posts(id)
);

-- for history of user updates
CREATE UNLOGGED TABLE user_history (
    user_id UUID,
    username VARCHAR(255),
    status INT CHECK (status BETWEEN 1 AND 6),
    email VARCHAR(255),
    created_at TIMESTAMP DEFAULT NOW()
);

