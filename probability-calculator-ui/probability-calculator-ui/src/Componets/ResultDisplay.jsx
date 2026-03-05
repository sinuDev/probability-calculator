import React from "react";

const ResultDisplay = ({ result }) => {
  if (result === null) return null;

  return <div className="result-box"> Result: {Number(result).toFixed(4)}</div>;
};

export default ResultDisplay;
