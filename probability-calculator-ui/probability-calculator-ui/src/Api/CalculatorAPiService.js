import apiClient from "../Api/ApiClient";

export const calculateProbability = async (data) => {
  const response = await apiClient.post("/Probability/calculate", data);
  return response.data;
};
