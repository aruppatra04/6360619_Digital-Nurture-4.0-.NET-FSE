import React from 'react';
import Post from './Post';

class Posts extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            posts: [],
        };
    }

    loadPosts() {
        fetch('https://jsonplaceholder.typicode.com/posts')
            .then(response => response.json())
            .then(data => this.setState({ posts: data }))
            .catch(error => {
                console.error('Error fetching posts:', error);
                alert("Failed to load posts.");
            });
    }

    componentDidMount() {
        this.loadPosts();
    }

    componentDidCatch(error, info) {
        alert("Something went wrong: " + error);
    }

    render() {
        return (
            <div style={{ padding: "20px" }}>
                <h1>Blog Posts</h1>
                {
                    this.state.posts.map(post => (
                        <Post key={post.id} title={post.title} body={post.body} />
                    ))
                }
            </div>
        );
    }
}

export default Posts;
