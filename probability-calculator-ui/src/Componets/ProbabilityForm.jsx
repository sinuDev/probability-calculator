import React, { useState } from "react";
import { calculateProbability } from "../Api/CalculatorAPiService";
import ResultDisplay from "./ResultDisplay";

const ProbabilityForm = () => {
  const [probabilityA, setProbabilityA] = useState("");
  const [probabilityB, setProbabilityB] = useState("");
  const [calculationType, setCalculationType] = useState(1);
  const [result, setResult] = useState(null);
  const [error, setError] = useState("");

  const handleCalculate = async () => {
    const a = parseFloat(probabilityA);
    const b = parseFloat(probabilityB);

    if (isNaN(a) || isNaN(b)) {
      setError("Please enter valid numbers");
      return;
    }

    if (a < 0 || a > 1 || b < 0 || b > 1) {
      setError("Probability must be between 0 and 1");
      return;
    }

    setError("");

    try {
      const response = await calculateProbability({
        probabilityA: a,
        probabilityB: b,
        calculationType: parseInt(calculationType),
      });

      setResult(response.result);
    } catch {
      setError("Error calling API");
    }
  };

  return (
    <div>
      <div className="form-group">
        <label>Probability A</label>
        <input
          type="number"
          step="0.01"
          value={probabilityA}
          onChange={(e) => setProbabilityA(e.target.value)}
        />
      </div>

      <div className="form-group">
        <label>Probability B</label>
        <input
          type="number"
          step="0.01"
          value={probabilityB}
          onChange={(e) => setProbabilityB(e.target.value)}
        />
      </div>

      <div className="form-group">
        <label>Calculation Type</label>
        <select
          value={calculationType}
          onChange={(e) => setCalculationType(e.target.value)}
        >
          <option value={1}>CombinedWith</option>
          <option value={2}>Either</option>
        </select>
      </div>

      <button className="calculate-btn" onClick={handleCalculate}>
        Calculate
      </button>

      {error && <div className="error-text">{error}</div>}

      <ResultDisplay result={result} />
    </div>
  );
};

export default ProbabilityForm;
