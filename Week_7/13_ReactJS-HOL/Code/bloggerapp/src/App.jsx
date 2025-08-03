import React from "react";
import "./App.css";
import CourseDetails from "./components/CourseDetails";
import BookDetails from "./components/BookDetails";
import BlogDetails from "./components/BlogDetails";

function App() {
  const courses = [
    { name: "Angular", date: "4/5/2021" },
    { name: "React", date: "6/3/20201" },
  ];

  const books = [
    { id: 101, bname: "Master React", price: 670 },
    { id: 102, bname: "Deep Dive into Angular 11", price: 800 },
    { id: 103, bname: "Mongo Essentials", price: 450 },
  ];

  const blogs = [
    {
      title: "React Learning",
      author: "Stephen Biz",
      content: "Welcome to learning React!",
    },
    {
      title: "Installation",
      author: "Schwezdenier",
      content: "You can install React from npm.",
    },
  ];

  return (
    <div className="container">
      <CourseDetails courses={courses} />
      <BookDetails books={books} />
      <BlogDetails blogs={blogs} />
    </div>
  );
}

export default App;
