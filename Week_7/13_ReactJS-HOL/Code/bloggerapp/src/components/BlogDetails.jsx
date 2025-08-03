import React from "react";

function BlogDetails({ blogs }) {
  return (
    <div className="column v1">
      <h1>Blog Details</h1>
      {blogs.map((blog, index) => (
        <div key={index} className="item">
          <h3>{blog.title}</h3>
          <h4 className="author">{blog.author}</h4>
          <p>{blog.content}</p>
        </div>
      ))}
    </div>
  );
}

export default BlogDetails;
