import React from "react";
import ProbabilityForm from "../Componets/ProbabilityForm";
import "../styles/calculator.css";

const CalculatorPage = () => {
  return (
    <div className="calculator-container">
      <div className="calculator-card">
        <h2 className="calculator-title">Probability Calculator</h2>
        <ProbabilityForm />
      </div>
    </div>
  );
};

export default CalculatorPage;
