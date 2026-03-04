import React from "react";

const ResultDisplay = ({ result }) => {
  if (result === null || result === undefined) {
    return null;
  }

  return (
    <div style={{ marginTop: "20px" }}>
      <h3>Result: {result}</h3>
    </div>
  );
};

export default ResultDisplay;
