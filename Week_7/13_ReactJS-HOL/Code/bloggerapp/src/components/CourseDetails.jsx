import React from "react";

function CourseDetails({ courses }) {
  return (
    <div className="column mystyle1">
      <h1>Course Details</h1>
      {courses.map((course, index) => (
        <div key={index} className="item">
          <h3>{course.name}</h3>
          <p>{course.date}</p>
        </div>
      ))}
    </div>
  );
}

export default CourseDetails;
